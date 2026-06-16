namespace SimpleCode_Course_Part_2.Lesson62;

/// <summary>
/// Свойства (Properties)
///
/// Автоматические свойства
/// </summary>
public class Point
{
    private int x;
    private int y = 99;
    public int Z { get; set; }

    private int Y
    {
        // get => y;
        set
        {
            if (value < 0)
            {
                y = 1;
            }
        
            if (value > 5)
            {
                y = value;
            }
            y = value;
        }
    }


    public void setX(int x)
    {
        if (x < 0)
        {
            this.x = 1;
            return;
        }
        
        if (x > 5)
        {
            this.x = 5;
            return;
        }
        
        this.x = x;
    }
    
    public int getX()
    {
        return x;
    }
}