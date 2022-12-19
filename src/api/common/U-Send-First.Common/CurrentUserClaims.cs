namespace U_Send_First.Common;

public class CurrentUserClaims : IClaims
{
    public CurrentUserClaims()
    {
        CurrentUser = new CurrentUser();
    }
    public bool IsAuthenticated {get; set ; }
    public CurrentUser CurrentUser { get; set; }
}
