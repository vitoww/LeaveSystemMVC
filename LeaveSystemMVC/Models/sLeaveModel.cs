﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemMVC.Models
{
    public class sLeaveModel
    {

        public string staffName { get; set; } = "Dwayne";

        
        // [DisplayName("Select Leave Type")]
        [Required(ErrorMessage = "Please select leave type")]
        public String leaveType { get; set; } = "Annual";

        //[DisplayName("Select Application Date")]
        [Required(ErrorMessage = "Please select leave application date")]
        public DateTime applicationDate { get; set; } = new DateTime(24-11-2016);

        [DisplayName("Select Leave Start Date")]
        [Required(ErrorMessage = "Please select leave start date")]
        public DateTime startDate { get; set; } = new DateTime(24 - 12 - 2016);

        [DisplayName("Select Leave End Date")]
        [Required(ErrorMessage = "Please select leave end date")]
        public DateTime endDate { get; set; } = new DateTime(24 - 1 - 2017);

        public DateTime returnDate { get; set; } = new DateTime(24 - 1 - 2017);

        [DisplayName("Leave Duration")]
        [Required(ErrorMessage = "Please enter the leave duration before submitting form")]
        public int leaveDuration { get; set; } = 30;

        [DisplayName("Select Leave Start Time")]
        [Required(ErrorMessage = "Please select leave start time")]
        public DateTime shortStartTime { get; set; } = new DateTime(24 - 1 - 2017);

        [DisplayName("Select Leave End Time")]
        [Required(ErrorMessage = "Please select leave end time")]
        public DateTime shortEndTime { get; set; } = new DateTime(24 - 1 - 2017);

        [DisplayName("Line Manager Comment")]
        public string lmComment { get; set; } = "Leave Approved";

        [DisplayName("HR Comment")]
        public string hrComment { get; set; } = "Leave Approved";

        [DisplayName("Leave Status")]
        public int leaveStatus { get; set; } = 1;

        [DisplayName("Enter Comments")]
        public string comments { get; set; } = "Taking Annual Leave";

        [DisplayName("Upload Supporting Docs")]
        public string supportingDocs { get; set; } = "/abc";

        [DisplayName("Book Air Ticket?")]
        public bool bookAirTicket { get; set; } = true;

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "You must provide your home phone number.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "You must provide a proper phone number.")]
        [RegularExpression(@"^(?:\+971|00971|0)?(?:50|51|52|55|56|2|3|4|6|7|9)\d{7}$", ErrorMessage = "You must provide a proper phone number.")]
        public string contactDetails { get; set; } = "052123344";
    }
}