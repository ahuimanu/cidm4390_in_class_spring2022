namespace domain.SpeakerAggregate;

// this is an example of "I" in SOLID
public interface ISpeakerHelper
{
    public string ValidateFirstName(string fname);
    public string ValidateLastName(string lname);
    public string GetEmailAddrress(string email);

    public Speaker CreateSpeaker(string fname, string lname, string email);
}

public class MySpeakerHelper : ISpeakerHelper
{
    public string ValidateFirstName(string fname)
    {
        // TODO: validation steps
        if(fname.Length == 0){
            throw new ArgumentException();
        }
        if(fname == null)
        {
            throw new ArgumentException();
        }
        return fname;
    }
    public string ValidateLastName(string lname)
    {
        return string.Empty;
    }
    public string GetEmailAddrress(string email)
    {
        return string.Empty;
    }

    public Speaker CreateSpeaker(string fname, string lname, string email)
    {
        Speaker speaker = new Speaker()
        {
            FirstName = ValidateFirstName(fname),
        };
    }

}