using System;
using System.Collections.Generic;

// NOTE: Tambahkan pengecekan untuk relative path dari file yang valid!
// NOTE: Untuk mendapatkan ID, dapat melakukan query untuk menemukan id yang terakhir kemudian ditambah 1.

namespace Class_PamerYuk
{
    public class Konten
    {
        #region Data Member
        private int id;
        private string caption;
        private string foto;
        private string video;
        private DateTime tanggalUpload;
        private List<User> daftarLike;
        private List<User> daftarTag;
        private List<Komen> daftarKomentar;
        #endregion

        #region Constructor
        public Konten(int id, string caption, string foto, string video, DateTime tanggalUpload)
        {
            Id = id;
            Caption = caption;
            Foto = foto;
            Video = video;
            TanggalUpload = tanggalUpload;
            DaftarLike = new List<User>();
            DaftarTag = new List<User>();
            DaftarKomentar = new List<Komen>();
        }

        public Konten(int id, string caption, string foto, string video, DateTime tanggalUpload, List<User> daftarLike, List<User> daftarTag, List<Komen> daftarKomentar)
        {
            Id = id;
            Caption = caption;
            Foto = foto;
            Video = video;
            TanggalUpload = tanggalUpload;
            DaftarLike = daftarLike;
            DaftarTag = daftarTag;
            DaftarKomentar = daftarKomentar;
        }
        #endregion

        #region Property
        public int Id 
        { 
            get => id; 
            private set
            {
                if (value < 1) throw new ArgumentException("Class: Konten | Id must be greater than 0!");
                else id = value;
            }
        }
        public string Caption 
        { get => caption; private set => caption = value; }
        public string Foto { get => foto; private set => foto = value; }
        public string Video { get => video; private set => video = value; }
        public DateTime TanggalUpload 
        { 
            get => tanggalUpload;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: Konten | TanggalUpload can't be null!");
                else if (value.CompareTo(DateTime.Now) > 0) throw new ArgumentException("Class: Konten | TanggalUpload can't be greater than today!");
                else tanggalUpload = value;
            }
        }
        public List<User> DaftarLike 
        { 
            get => daftarLike; 
            set
            {
                if (value == null) throw new ArgumentNullException("Class: Konten | DaftarLike can't be null!");
                else daftarLike = value;
            } 
        }
        public List<User> DaftarTag 
        { 
            get => daftarTag; 
            set
            {
                if (value == null) throw new ArgumentException("Class: Konten | DaftarTag can't be null!");
                else daftarTag = value;
            } 
        }
        public List<Komen> DaftarKomentar 
        { 
            get => daftarKomentar; 
            set
            {
                if (value == null) throw new ArgumentException("Class: Konten | DaftarKomentar can't be null!");
                else daftarKomentar = value;
            }
        }
        #endregion

        #region Method
        public void AddLike(User u)
        {
            DaftarLike.Add(u);
        }

        public void AddTag(User u)
        {
            DaftarTag.Add(u);
        }

        public void AddComment(Komen k)
        {
            DaftarKomentar.Add(k);
        }

        public void Dislike(User u)
        {
            foreach (User temp in DaftarLike)
            {
                if (temp.Username == u.Username)
                {
                    DaftarLike.Remove(temp);
                    break;
                }
            }
        }

        public void RemoveTag(User u)
        {
            foreach (User temp in DaftarTag)
            {
                if (temp.Username == u.Username)
                {
                    DaftarTag.Remove(temp);
                    break;
                }
            }
        }

        public void DeleteComment(Komen k)
        {
            foreach (Komen temp in DaftarKomentar)
            {
                if (temp.Id == k.Id)
                {
                    DaftarKomentar.Remove(temp);
                    break;
                }
            }
        }
        #endregion
    }
}
