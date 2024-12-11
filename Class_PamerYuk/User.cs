using System;
using System.Collections.Generic;

namespace Class_PamerYuk
{
    public class User
    {
        #region Data Member
        private string username;
        private DateTime tglLahir;
        private string noKTP;
        private string foto;
        private Kota kota;
        private List<KisahHidup> daftarKisahHidup;
        private List<User> daftarTeman;
        private List<Konten> daftarKonten;
        #endregion

        #region Constructor
        public User(string username, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            Username = username;
            TglLahir = tglLahir;
            NoKTP = noKTP;
            Foto = foto;
            Kota = kota;
            DaftarKisahHidup = new List<KisahHidup>();
            DaftarTeman = new List<User>();
            daftarKonten = new List<Konten>();
        }

        public User(string username, DateTime tglLahir, string noKTP, string foto, Kota kota, List<KisahHidup> kisahHidup, List<User> daftarTeman, List<Konten> daftarKonten)
        {
            Username = username;
            TglLahir = tglLahir;
            NoKTP = noKTP;
            Foto = foto;
            Kota = kota;
            DaftarKisahHidup = daftarKisahHidup;
            DaftarTeman = daftarTeman;
            DaftarKonten = daftarKonten;
        }
        #endregion

        #region Property
        public string Username 
        { 
            get => username; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: User | Username can't be null!");
                else if (value == "") throw new ArgumentException("Username tidak boleh kosong!");
                else if (value.Length > 40) throw new ArgumentException("Panjang username tidak boleh melebihi 40 karakter!");
                else username = value;
            } 
        }
        public DateTime TglLahir 
        { 
            get => tglLahir; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: User | TglLahir can't be null!");
                else if (value.CompareTo(DateTime.Now) > 0) throw new ArgumentException("Tanggal lahir tidak boleh lebih dari tanggal hari ini!");
                else tglLahir = value;
            }
        }
        public string NoKTP 
        { 
            get => noKTP; 
            private set
            {

                if (value == null) throw new ArgumentNullException("Class: User | NoKTP can't be null!");
                else if (value.Length != 16) throw new ArgumentException("Panjang nomor KTP adalah 16 karakter!");
                else if (!int.TryParse(value, out int t)) throw new ArgumentException("Nomor KTP hanya boleh mengandung angka!");
                else noKTP = value;
            } 
        }
        public string Foto 
        { 
            get => foto; 
            set
            {
                if (value == null || value == "") throw new ArgumentException("Class: User | Invalid value for field - foto");
                else foto = value;
            }
        }
        public Kota Kota 
        { 
            get => kota; 
            set
            {
                if (value == null) throw new ArgumentNullException("Class: User | Kota can't be null!");
                else kota = value;
            } 
        }
        public List<KisahHidup> DaftarKisahHidup 
        { 
            get => daftarKisahHidup; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: User | DaftarKisahHidup can't be null!");
                else daftarKisahHidup = value;
            }
        }
        public List<User> DaftarTeman 
        { 
            get => daftarTeman; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: User | DaftarTeman can't be null!");
                else daftarTeman = value;
            } 
        }
        public List<Konten> DaftarKonten 
        { 
            get => daftarKonten; 
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: User | DaftarKonten can't be null!");
                else daftarKonten = value;
            } 
        }
        #endregion

        #region Method
        public void AddKisahHidup(KisahHidup k)
        {
            DaftarKisahHidup.Add(k);   
        }

        public void AddFriend(User u)
        {
            DaftarTeman.Add(u);
        }

        public void AddContent(Konten k)
        {
            DaftarKonten.Add(k);
        }

        public void RemoveKisahHidup(KisahHidup k)
        {
            foreach (KisahHidup temp in DaftarKisahHidup)
            {
                if (temp.Organisasi.Id == k.Organisasi.Id)
                {
                    DaftarKisahHidup.Remove(temp);
                    break;
                }
            }
        }

        public void RemoveFriend (User u)
        {
            foreach (User temp in DaftarTeman)
            {
                if (temp.Username == u.Username)
                {
                    DaftarTeman.Remove(temp);
                    break;
                }
            }
        }

        public void DeleteContent(Konten k)
        {
            foreach (Konten temp in DaftarKonten)
            {
                if (temp.Id == k.Id)
                {
                    DaftarKonten.Remove(temp);
                    break;
                }
            }
        }
        #endregion
    }
}
