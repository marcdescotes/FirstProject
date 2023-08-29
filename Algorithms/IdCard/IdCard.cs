using Algorithms.IdCard;

public class IdCard
{
    private Name name;
    private PostalCode postalCode;
    private TelephonNumber telephoneNumber;

    public IdCard(Name name,
                  PostalCode postalCode,
                  TelephonNumber telephoneNumber)
    {

        this.name = name;
        this.postalCode = postalCode;
        this.telephoneNumber = telephoneNumber;
    }

    public bool IsValid()
    {
        return name.IsValid()
        && telephoneNumber.IsValid()
        && postalCode.IsValid();
    }
}