using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class ActionSection : Sections

    {
        public ActionSection(SectionType type, int MaxBooks) : base(SectionType.Action, MaxBooks)
        {
            AddBook(new Book("الجزار", "رواية انتقام وسلسة من محاولات الوصول الى القاتل", 200, "Hassan Elgndy"));
            AddBook(new Book("يوتوبيا", "شاب غني من يوتوبيا يقوم بمغامرة وصيد الفقراء لكسر الملل", 220, "Ahmed Khaled"));
            AddBook(new Book("The cold storm", "On a winter trip, Roger must save his family from a gang of killers", 180, "John Etterlee"));
            AddBook(new Book("The Hunter", "two men comming to the village for gold but instead they got in trouble", 250, "Tana French"));
            AddBook(new Book("The walk", "An excutive who loses everything on a walk that changes his life", 300, "Richard Paul"));
            AddBook(new Book("The Hunger Games", "Where young participants are forced to fight to the death", 325, "Suzanne Collins"));
        }
    }
}





