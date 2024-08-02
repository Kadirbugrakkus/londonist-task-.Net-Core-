using CrmApp.Core.Entities;

namespace CrmApp.Models.Requests
{
    public class ContactRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CountryId { get; set; }
        public string? Phone { get; set; }
        public DateTime MeetingDate { get; set; }
        public string? Budget { get; set; }
        public int BedroomsCount { get; set; }


        public Contact ToContact()
        {
            return new Contact
            {
                FirstName = FirstName,
                LastName = LastName,
                CountryId = CountryId,
                Phone = Phone,
                MeetingDate = MeetingDate,
                Budget = Budget,
                BedroomsCount = BedroomsCount
            };
        }

        public bool IsValid(out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrEmpty(FirstName))
            {
                errorMessage = "First name is required";
                return false;
            }

            if (string.IsNullOrEmpty(LastName))
            {
                errorMessage = "Last name is required";
                return false;
            }

            if (CountryId <= 0)
            {
                errorMessage = "CountryId must be a valid number";
                return false;
            }

            if (string.IsNullOrEmpty(Phone))
            {
                errorMessage = "Phone is required";
                return false;
            }

            if (MeetingDate == DateTime.MinValue)
            {
                errorMessage = "MeetingDate is required";
                return false;
            }

            if (string.IsNullOrEmpty(Budget))
            {
                errorMessage = "Budget is required";
                return false;
            }

            if (BedroomsCount < 1)
            {
                errorMessage = "BedroomsCount must be at least 1";
                return false;
            }

            return true;
        }

    }
}