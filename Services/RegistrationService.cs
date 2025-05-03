using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class RegistrationService
    {
        private readonly List<RegistrationModel> registrations = new();

        public void AddRegistration(RegistrationModel registration)
        {
            registrations.Add(registration);
        }

        public List<RegistrationModel> GetRegistrations()
        {
            return registrations;
        }
    }
}


