using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> allVideo = new List<Video>();

        Video v1 = new Video();
        v1._author = "Eva";
        v1._title = "tuto for the product eva-shumpoo";
        v1._length = 300;
        allVideo.Add(v1); 

        Video v2 = new Video();
        v2._author = "Fielden";
        v2._title = "how to prepare for long trip with your motocycle";
        v2._length = 500;
        allVideo.Add(v2);

        Video v3 = new Video();
        v3._author = "Geralde clerk";
        v3._title = "the best usefull phrases in Enlglish for the beginers ";
        v3._length = 300;
        allVideo.Add(v3); 

        Commnent c1 = new Commnent();
        c1._comment = "thanks eva it really helpful";
        c1._name = "nicki";
        c1._names.Add(c1._name);
        c1._allcomments.Add(c1._name);

        c1._comment = "amizing TUTO eva, waiting for the next video";
        c1._name = "Angela";
        c1._names.Add(c1._name);
        c1._allcomments.Add(c1._comment);

        c1._comment = "wonderful video";
        c1._name = "Nancy";
        v1.Commentes.Add(c1);
        c1._allcomments.Add(c1._comment);


        Commnent c2 = new Commnent();
        c2._comment = "thanks for all that tips";
        c2._name = "kelly";
        c2._names.Add(c2._name);
        c2._allcomments.Add(c2._comment);
        c2._comment = "Riding with moto is good bro, thanks";
        c2._name = "kenny";
        c2._names.Add(c2._name);
        c2._allcomments.Add(c2._comment);
        c2._comment = "hepfull man!";
        c2._name = "Monford";
        c2._allcomments.Add(c2._comment);
        v2.Commentes.Add(c2);

        Commnent c3 = new Commnent();
        c3._comment = "I learn a lot from this video, thank you so much";
        c3._name = "kevine";
        c3._allcomments.Add(c3._comment);
        c3._names.Add(c3._name);
        c3._comment = "amizing teaching, you are the best";
        c3._name = "stenny";
        c3._names.Add(c3._name);
        c3._allcomments.Add(c3._comment);
        c3._comment = "wonderful video";
        c3._name = "jenny";
        c3._allcomments.Add(c3._comment);
        v3.Commentes.Add(c3);

        foreach(Video v in allVideo)
        {
            v.infoVideo();
        }

    }
}