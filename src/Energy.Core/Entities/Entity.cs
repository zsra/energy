namespace Energy.Core.Entities
{
    public abstract class Entity
    {
        public virtual string Id { get; protected set; }
        public string PartitionKey { get; protected set; }
    }
}
