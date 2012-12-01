using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Domain
{
    #region [ABSTRACT CLASSES]
    public abstract class WTEvent
    {
        public int Id { get; set; }

        public DateTime Begin { get; set; }

        public DateTime End { get; set; }

        public String Title { get; set; }

        public String Location { get; set; }

        public String Description { get; set; }
    }

    public abstract class WTLike
    {
        public int Like { get; set; }

        public bool CanLike { get; set; }
    }

    public abstract class WTFavorite
    {
        public int Favorite { get; set; }

        public bool CanFavorite { get; set; }
    }

    public abstract class WTSchedule
    {
        public int Schedule { get; set; }
        public bool CanSchedule { get; set; }
    }

    public abstract class WTOrganizer
    {
        public String Organizer { get; set; }

        public String OrganizerAvatar { get; set; }
    }

    public abstract class WTRead
    {
        public int Read { get; set; }
    }

    public abstract class WTNews : WTRead
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String Source { get; set; }

        public String Summary { get; set; }

        public String Context { get; set; }

        public IEnumerable<String> Images { get; set; }

        public DateTime CreatedAt { get; set; }
    }
    #endregion

    #region [User]
    public class User
    {
        public String NO { get; set; }

        public String Name { get; set; }

        public String Avatar { get; set; }

        public String UID { get; set; }

        public String Phone { get; set; }

        public String DisplayName { get; set; }

        public String Major { get; set; }

        public String NativePlace { get; set; }

        public String Degree { get; set; }

        public String Gender { get; set; }

        public String Year { get; set; }

        public DateTime Birthday { get; set; }

        public String Plan { get; set; }

        public String SinaWeibo { get; set; }

        public String QQ { get; set; }

        public String Department { get; set; }

        public String Email { get; set; }
    }
    #endregion

    #region [Course]
    public class Course
    {
        public String NO { get; set; }

        public int Hours { get; set; }

        public float Point { get; set; }

        public String Name { get; set; }

        public String Teacher { get; set; }

        public String WeekType { get; set; }

        public String WeekDay { get; set; }

        public int SectionStart { get; set; }

        public int SectionEnd { get; set; }

        public bool Required { get; set; }

        public String Location { get; set; }
    }
    #endregion

    #region [Event]
    public class Event : WTEvent
    {

    }
    #endregion

    #region [Activity]
    public class Activity : WTEvent
    {
        public int Like { get; set; }

        public bool CanLike { get; set; }

        public int Favorite { get; set; }

        public bool CanFavorite { get; set; }

        public int Schedule { get; set; }

        public int CanSchedule { get; set; }

        public int Channel_id { get; set; }

        public String Organizer { get; set; }

        public String OrganizerAvatar { get; set; }

        public String Status { get; set; }

        public String Image { get; set; }

        public DateTime CreatedAt { get; set; }
    }
    #endregion

    #region [Channel]

    public class Channel
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String Url { get; set; }

        public int Follow { get; set; }

        public String Description { get; set; }
    }

    #endregion

    #region [Exam]

    public class Exam
    {
        public String NO { get; set; }

        public String Name { get; set; }

        public String Teacher { get; set; }

        public String Location { get; set; }

        public DateTime Begin { get; set; }

        public DateTime End { get; set; }

        public float Point { get; set; }

        public bool Required { get; set; }

        public int Hours { get; set; }
    }
    
    #endregion

    #region [School News]
    public class SchoolNews : WTNews
    {
        public int Like { get; set; }

        public bool CanLike { get; set; }

        public int Favorite { get; set; }

        public bool CanFavorite { get; set; }
    }
    #endregion

    #region [Club News]
    public class ClubNews : WTNews
    {
        public int Like { get; set; }

        public bool CanLike { get; set; }

        public int Favorite { get; set; }

        public bool CanFavorite { get; set; }

        public String Organizer { get; set; }

        public String OrganizerAvatar { get; set; }
    }
    #endregion

    #region [Around]
    public class Around : WTNews
    {
        public int Like { get; set; }

        public bool CanLike { get; set; }

        public int Favorite { get; set; }

        public bool CanFavorite { get; set; }
    }
    #endregion

    #region [For Staff]
    public class ForStaff : WTNews
    {
        public int Like { get; set; }

        public bool CanLike { get; set; }

        public int Favorite { get; set; }

        public bool CanFavorite { get; set; }
    }
    #endregion

    #region [Version]
    public class Version
    {
        public String Current { get; set; }

        public String Latest { get; set; }

        public String Url { get; set; }
    }
    #endregion

    #region [Person]
    public class Person
    {
        public String Id { get; set; }

        public String Name { get; set; }

        public String JobTitle { get; set; }

        public String Words { get; set; }

        public String NO { get; set; }

        public String Avatar { get; set; }

        public String Title { get; set; }

        public IEnumerable<String> Images { get; set; }

        public String Description { get; set; }

        public String Read { get; set; }

        public int Like { get; set; }

        public bool CanLike { get; set; }

        public int Favorite { get; set; }

        public bool CanFavorite { get; set; }
    }
    #endregion
}
