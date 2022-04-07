var randoms = new List<object>();

object ob1 = new();
ob1 = 23;

object ob2 = new();
ob2 = "33";

object ob3 = new();
ob3 = "ttt";

object ob4 = new();
ob4 = 3.5;

object ob5 = new();
ob5 = 12;

//randoms.Add(ob1);
randoms.Add(ob2);
randoms.Add(ob3);
randoms.Add(ob4);
randoms.Add(ob5);

Console.Write(Util.MinValue(randoms));


public static class Util
{
    public static string MinValue(List<object> valObj)
    {
        List<object> newObj = new List<object>();
        var message = "Sorry No Valid Integer Found in the List";

        foreach (var obj in valObj)
        {
            if (obj is int)
            {
                newObj.Add(obj);
            }
        }

        //Sort list of newObj in ascending order
        newObj.Sort();

        //get first index sorted list

        if (newObj.Count > 0)
        {
            message = newObj[0].ToString();
        }
        return message;
    }
}