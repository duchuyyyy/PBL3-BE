﻿using MyOToVer1._2.Data;

namespace MyOToVer1._2.Models.DataModels
{
    public class TransferEvidencePhotoModel
    {
        private ApplicationDBContext db;

        public TransferEvidencePhotoModel(ApplicationDBContext db)
        {
            this.db = db;
        }

        public void AddEvidencePhoto(TransferEvidencePhoto obj)
        {
            db.TransferEvidencePhotos.Add(obj);
            db.SaveChanges();
        }
    }
}
