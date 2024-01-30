﻿using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Ticket
    {
        [Display(Name = "شناسه")]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        /// <summary>
        /// توضیحات متنی تیکت یا درخواست
        /// </summary>
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name ="اولویت")]
        public PriorityEnum Priority { get; set; }


        //public int DepartmentId { get; set; }
        [Display(Name = "نام سازمان")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// زمان ثبت تیکت
        /// </summary>
        ///
        [Display(Name = "زمان ارسال")]
        public DateTime SubmittedAt { get; set; }

        /// <summary>
        /// آی دی شخصی که تیکت را ثبت کرده است
        /// </summary>
        ///
        [Display(Name = "کد شخص ارسال کننده")]
        public int SubmittedBy { get; set; }
    }

    //public class Department
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
