using APITugasMod9_Kel10.Models.Dto;

namespace APITugasMod9_Kel10.Data
{
    public static class AccountStore
    {
        public static List<AccountDTO> accountList = new List<AccountDTO>
        {
             new AccountDTO{Id=1, Username="admin", Password="root"},
             new AccountDTO{Id=2, Username="abcde", Password="1234"}
        };
    }
}
