using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[Serializable]
public class User
{
    public string Name { get; set; }
}

[Serializable]
[XmlRoot("Users")]
public class UserList
{
    [XmlElement("User")]
    public List<User> Users { get; set; } = new List<User>();
}