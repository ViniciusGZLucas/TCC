﻿namespace Domain.Entry
{
    public class Course : BaseEntry
    {
        public Course() { }

        public Course(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        #region Virtual Properties
        #region External
        public virtual List<Advisor> ListAdvisor { get; set; }
        #endregion
        #endregion
    }
}
