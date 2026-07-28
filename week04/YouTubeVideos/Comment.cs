using System;
public class Comment
{
    public string CommenterName{ get; set;}
    public string Text { get; set;}

    public Comment(string commenterName, String text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}