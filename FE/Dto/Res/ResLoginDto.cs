namespace FE.Dto.Res
{
    public class LoginResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public UserData data { get; set; }
    }

    public class UserData
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public string jwtToken { get; set; }
    }
}
