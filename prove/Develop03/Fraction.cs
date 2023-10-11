public class Fraction{
    private Double _TopNum;
    private Double _BottomNum;

    public Fraction(){
        _TopNum = 1;
        _BottomNum = 1;
    }

    public Fraction(double WholeNum){
        _TopNum = WholeNum;
        _BottomNum = 1;
    }

    public Fraction(double TopNum, double BottomNum){
        _TopNum = TopNum;
        _BottomNum = BottomNum;
    }

    public string GetFractionString(){
        string num = $"{_TopNum}/{_BottomNum}";
        return num;
    }
    public double GetDecimalValue(){
        return _TopNum / _BottomNum;
    }
}