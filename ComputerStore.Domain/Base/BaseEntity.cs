
namespace ComputerStore.Domain.Base
{
    public abstract class BaseEntity<Tid> : IBaseEntity

    {
        protected BaseEntity()
        {

        }

        public BaseEntity(Tid id)
        {
            Id = id;
        }

        public Tid Id { get; set; }

    }
}
