namespace stapel;
public class Stapel<T> : IStapel<T>{
    private class Node{
        public T Waarde  {get; set;}
        public Node Volgende {get; set;}

        public Node (T waarde, Node volgende){
            Waarde = waarde;
            Volgende = volgende;
        }
    }

    private Node? Bovenste; 

     public void Duw(T waarde){
        Bovenste = new Node(waarde, Bovenste);
    }

    public T Pak(){
        if (Bovenste == null){
            throw new InvalidOperationException("Stack is empty.");
        }

        T value = Bovenste.Waarde;
        Bovenste = Bovenste.Volgende;
        return value;
    }
} 

public interface IStapel<T>{
    void Duw(T waarde);
    T Pak();
}

public class StapelStart{
    public static void Main(string[] args){
        Stapel<int> stapel = new Stapel<int>();
        stapel.Duw(1);
        stapel.Duw(2);
        stapel.Duw(3);
        Console.WriteLine(stapel.Pak());
        Console.WriteLine(stapel.Pak());
        Console.WriteLine(stapel.Pak());
    }
}