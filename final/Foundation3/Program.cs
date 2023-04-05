using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Address address1 = new Address("Ivato","Antananarivo");
        BaseEvent e1 = new BaseEvent();
        e1._addressList.Add(address1);
        string a = e1._addressList[0].GetAddress();
        Lecture lecture = new Lecture("meeting","presenting the upcomming project","22 April 2023","9:00 Am","Lectures",a,"Joh Di","Reporter");
        Console.WriteLine(lecture.StandardLecture());
        Console.WriteLine(lecture.FullLecture());
        Console.WriteLine(lecture.ShortLecture());
        Console.WriteLine();

        Address address2 = new Address("Mamory","Antananarivo");
        BaseEvent e2 = new BaseEvent();
        e1._addressList.Add(address2);
        string b = e1._addressList[0].GetAddress();
        Receptions reception  = new Receptions("meeting","Benefit of the upcoming project","22 Mars 2024","2:00 Pm","Receptions",b,"mamonjisoajohnny@gmail.com");
        Console.WriteLine(reception.StandardReceptions());
        Console.WriteLine(reception.FullReceptions());
        Console.WriteLine(reception.ShortReceptions());
        Console.WriteLine();

        Address address3 = new Address("Place Nova Hotel","Ivato");
        BaseEvent e3 = new BaseEvent();
        e3._addressList.Add(address1);
        string c = e3._addressList[0].GetAddress();
        OutdoorGathering outdoor = new OutdoorGathering("meeting","Starting the new project","20 June 2024","10:00 Am","OutdoorGathering",c,"clear (the sun is up)");
        Console.WriteLine(outdoor.StandardOutdoor());
        Console.WriteLine(outdoor.FullOutdoor());
        Console.WriteLine(outdoor.ShortOutdoor());

        
    }
    
}