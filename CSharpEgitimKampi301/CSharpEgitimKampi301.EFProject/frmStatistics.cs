﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class frmStatistics : Form
    {
        EgitimKampiEfTravelDBEntities1 db = new EgitimKampiEfTravelDBEntities1();
        public frmStatistics()
        {
            InitializeComponent();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();

            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();

            lblGuideCount.Text = db.Guide.Count().ToString();

            lblAvarageCapacity.Text = db.Location.Average(x => x.Capacity).ToString("0.00");

            lblAvgTourPrice.Text = db.Location.Average(x => x.Price).ToString("0.00") + "₺";
            
            //
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location
                .Where(x => x.LocationId == lastCountryId)
                .Select(y => y.Country)
                .FirstOrDefault();
           
            //
            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            
            //
            lblTurkiyeCapacityAvarage.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            //
            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomaTourGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            //
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
            
            //
            var maxExpensiveTour = db.Location.Max(x => x.Price);
            lblMaxExpensiveTour.Text = db.Location.Where(x => x.Price == maxExpensiveTour).Select(y => y.City + "\n" + "Fiyat:" + y.Price).FirstOrDefault().ToString();

            //
            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();

        }


    }
}
