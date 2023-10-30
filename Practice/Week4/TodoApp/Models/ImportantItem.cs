
class ImportantItem : TodoItem
{
    public string Priority { get; private set; }

    public ImportantItem(int index)
    {
        PriorityLevel(index);
    }

    public void PriorityLevel(int index)
    {
        switch (index)
        {
            case 0:
                Priority = "Az Önemli";
                break;
            case 1:
                Priority = "Önemli";
                break;
            case 2:
                Priority = "Çok Önemli";
                break;
            default:
                Priority = "Atanmadı";
                break;
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Priority}";
    }
}