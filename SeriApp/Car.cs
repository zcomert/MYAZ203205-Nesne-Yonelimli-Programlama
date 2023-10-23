class Car
{
    public String model;
    public int year;
    private float horsePower;
    private float averageConsume=5;
    public void Drive(){
        System.Console.WriteLine("Araba gidiyor");

    }
    public void Stop(){
        System.Console.WriteLine("Araba durdu");
    }
    public float GetAvaregeConsume(float distance){
        var result = (float)((distance*averageConsume)/100.0);
        return result;
    }

}