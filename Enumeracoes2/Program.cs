using System.Runtime.Serialization;
using Enumeracoes2.Entities;

Comment c1 = new Comment("Have a nice trip!");
Comment c2 = new Comment("Wow thats awesome!");
Post p1 = new Post(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Traveling to New Zeland",
    "I'm going to visti this wonderful country",
    12
);

p1.AddComment(c1);
p1.AddComment(c2);
