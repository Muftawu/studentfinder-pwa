namespace api.domain
{
       public static class Utilities
    {

        public static string GenerateReferenceNumber()
        {
            string UserId = "";
            Random rand = new Random();
            for (int i = 0; i < 2; i++)
            {
                UserId = string.Concat(UserId, rand.Next());
            }
            return UserId;
        }

        public static string GenerateEmail(string FirstName, string LastName)
        {
            string UserEmail = $"{FirstName[0]}{LastName[0]}@st.knust.edu.gh";
            return UserEmail.ToLower();
        }

        public static string GenerateUserId()
        {
            Guid userId = Guid.NewGuid();
            return userId.ToString();
        }

    }
}
