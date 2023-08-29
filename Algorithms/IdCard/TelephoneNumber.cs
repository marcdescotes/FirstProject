using System.Text.RegularExpressions;

namespace Algorithms.IdCard;

public class TelephonNumber
{
    private string telephoneNumber;

    public TelephonNumber(string telephoneNumber)
    {
        this.telephoneNumber = telephoneNumber;
    }



    public bool IsValid(){
        Regex rx = new Regex(@"^(\+?1 )?\d{3} \d{3}-\d{4}$");
        return rx.Match(this.telephoneNumber).Success;
    }

}