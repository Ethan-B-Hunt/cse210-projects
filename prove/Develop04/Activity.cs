using System.Reflection.Metadata;

public class Activity {
    private string _description;
    private string _name;
    private int _duration;
    // private DateOnly _start;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }
    public int DisplayDelay(int duration){
        _duration = duration;
        return _duration;
    }
// public ShowEndMessage(){

 //   }
 //   protected ShowMessageClause(string animationtype, int interval){

 //  }
 //   private ShowAnimation(animationType, interval){

 //   }
 //   protected bool KeepGoing(){

//    }
 //   protected GetRandomString(){

  //  }
}