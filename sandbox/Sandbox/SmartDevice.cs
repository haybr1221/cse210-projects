abstract class SmartDevice 
{
    protected string name;
    protected bool isOn;
    protected DateTime startTime;

    public virtual void FlipSwitch(string x) 
    {
        if (x == "on") 
        {
            isOn = true;
            startTime = DateTime.Now;
        }
        else
        {
            isOn = false;
        }
    }

    public bool CheckIfOn()
    {
        return isOn;
    }

    public int GetDuration()
    {
        if(isOn == true) 
        {
            return (int)(DateTime.Now - startTime).TotalSeconds;
            
        }
        else
        {
            return 0;
        }
    }

}