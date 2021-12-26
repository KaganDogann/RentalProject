namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {   // bu nesnemde ise hangi kullanıcının hangi claim'e yani yetkiye sahip olduğunu yazıyorum.
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
