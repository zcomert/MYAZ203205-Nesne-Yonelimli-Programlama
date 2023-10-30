class UrgentItem : ImportantItem
{
    public bool IsUrgent { get; set; }

    public UrgentItem(int index)
    : base(index)
    {
    }
    public UrgentItem(bool IsUrgent, int index)
    : base(index)
    {
        this.IsUrgent = IsUrgent;
    }
}