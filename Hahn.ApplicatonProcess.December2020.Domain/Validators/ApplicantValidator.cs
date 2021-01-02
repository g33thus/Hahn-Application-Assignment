using FluentValidation;
using Hahn.ApplicatonProcess.December2020.Domain.DTOs;
using System.Net.Http;

namespace Hahn.ApplicatonProcess.December2020.Domain.Validators
{
    public class ApplicantValidator : AbstractValidator<ApplicantDTO>
    {
        private readonly IHttpClientFactory _clientFactory;
        public ApplicantValidator(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            RuleFor(x => x.Name).Length(0, 5);
            RuleFor(x => x.FamilyName).Length(0, 5);
            RuleFor(x => x.Address).Length(0, 10);
            RuleFor(x => x.CountryOfOrigin).Must(ValidateCountry);
            RuleFor(x => x.EmailAddress).EmailAddress();
            RuleFor(x => x.Age).InclusiveBetween(20, 60);
            RuleFor(x => x.Hired).NotNull();
        }
        private bool ValidateCountry(string country)
        {
            if ((!string.IsNullOrEmpty(country) ))
            {
                var request = new HttpRequestMessage(HttpMethod.Get,
               "https://restcountries.eu/rest/v2/name/"+ country + "?fullText=true");
                var client = _clientFactory.CreateClient();
                var response =  client.SendAsync(request).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
