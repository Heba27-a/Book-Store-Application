using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class ScienceFiction : Sections
    {
        public ScienceFiction(SectionType type, int MaxBooks) : base(SectionType.ScienceFiction, MaxBooks)
        {
            AddBook(new Book("اخر ليالي البشر", "تدور الرواية بين عالمين وزمنين مختلفين، زمن الحروب ونهاية وجود البشر على الأرض", 270, "Mariem Ahmed Ali"));
            AddBook(new Book("ارسس", "تتحدث الرواية عن المهمشين اوا الغير مرئيين في المجتمع", 230, "Ahmed Al Hemdan"));
            AddBook(new Book("أرض بلا ظل", "تجربة مخيفة يعيشها البشر بعدما اختفت الظلال واصبح الجميع حبيس عقله", 210, "Mohamed Abdelal"));
            AddBook(new Book("Neuromancer", "Computer Hacker enlisted into a crew by a powerful artificial intelligence", 290, "William Gibson"));
            AddBook(new Book("City of stairs", "A city with miracles and powers", 260, "Robert Jackson"));
            AddBook(new Book("Contact", "It follows Ellie Arroway a radio astronomer who discovers a signal from the star", 550, "Carl Sagan"));
        }
    }
}





