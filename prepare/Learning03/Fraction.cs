public class Fraction {

    private int _top;
    private int _bottom;

    public Fraction() {
        // Set the default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    // public int GetTop() {
    //     return 
    // }

    // public void SetTop(int top) {

    // }

    // public int GetBottom() {
    //     return 
    // }

    // public void SetBottom(int bottom) {

    // }

    public string GetFractionString() {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue() {
        return (double)_top / (double)_bottom;
    }
}