/*
  Copyright 2018 Alexandre Pires - c.alexandre.pires@gmail.com

  Permission is hereby granted, free of charge, to any person obtaining a copy of this 
  software and associated documentation files (the "Software"), to deal in the Software 
  without restriction,  including without  limitation the  rights to use, copy, modify, 
  merge,  publish, distribute,  sublicense, and/or sell  copies of the Software, and to 
  permit persons to whom the Software  is furnished  to do so, subject to the following 
  conditions:

  The above copyright notice and this permission notice shall be included in all copies
  or substantial portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS",  WITHOUT WARRANTY OF  ANY KIND, EXPRESS OR IMPLIED, 
  INCLUDING  BUT  NOT  LIMITED TO  THE WARRANTIES  OF  MERCHANTABILITY,  FITNESS  FOR A 
  PARTICULAR PURPOSE AND  NONINFRINGEMENT.  IN NO  EVENT SHALL THE AUTHORS OR COPYRIGHT 
  HOLDERS BE LIABLE FOR ANY CLAIM,  DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
  CONTRACT, TORT OR  OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
  OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDFOnlineSignature.Models
{
    public class CertificateRequest
    {
        [Key,
            DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Uuid { get; set; }
        [Required]
        public string ReviewerUuid { get; set; }
        [Required]
        public Reviewer Reviewer { get; set; }
        [Display (Name = "Request Date"),
            DisplayFormat (DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true),
            Column(TypeName="date")]
        public DateTime? RequestDate { get; set; }
        [Required]
        public string SecurityCode { get; set; }
        public string CertificateUuid { get; set; }
        public Certificate Certificate { get; set; }
    }
}