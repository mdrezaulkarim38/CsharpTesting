using System.Security.Cryptography;

namespace Basic;

public class Membership
{
    public User CreateUser(string userName, string password)
    {
        User user = new User();
        user.UserId = GenerateId(userName);
        user.UserName = userName;
        user.Password = EncryptPassword(password);

        return user;
    }

    private string GenerateId(string userName)
    {
        Random random = new Random(DateTime.Now.Microsecond);
        return char.ToUpper(userName[0]).ToString() + random.Next();
    }

    private string EncryptPassword(string password)
    {
        return MD5.Create(password).ToString();
    }
}