using Program;

namespace blackjackApp;

public class Card{
    private string _value;
    private string _type;
    private int _valueInt;
    List<KeyValuePair<string, int>> cardValue = new()
    {
        new KeyValuePair<string, int>("Ace", 1),
        new KeyValuePair<string, int>("Two", 2),
        new KeyValuePair<string, int>("Three", 3),
        new KeyValuePair<string, int>("Four", 4),
        new KeyValuePair<string, int>("Five", 5),
        new KeyValuePair<string, int>("Six", 6),
        new KeyValuePair<string, int>("Seven", 7),
        new KeyValuePair<string, int>("Eight", 8),
        new KeyValuePair<string, int>("Nine", 9),
        new KeyValuePair<string, int>("Ten", 10),
        new KeyValuePair<string, int>("Jack", 10),
        new KeyValuePair<string, int>("Queen", 10),
        new KeyValuePair<string, int>("King", 10),
    };
    
    public Card(string type, string value)
    {
        _value = value;
        _type = type;
    }

    public int getValue()
    {
        foreach (var element in cardValue)
        {
            if (element.Key == _value)
            {
                //Console.WriteLine(element.Value);
                _valueInt = element.Value;
            }
        }

        return _valueInt; 
    }

    public string getType()
    {
        return _type;
    }

    public string ToString()
    {
        return _value + " of " + _type;
    }
    
}