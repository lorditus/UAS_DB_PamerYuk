# Project UAS Database
Membuat sebuah aplikasi pertemanan **PamerYuk**.  
#### Kelompok: 21 - Menyala DB kuu🚀🚀
|NRP|Anggota| KP
|-|-|-|
|160423002| Kenny Varenne Tin Setyabudi| F
|160423020| Kevin Nathaniel Sutopo| C
|160423098| Daniel Yang| A
|160422142| Aulia Novianty Lamanasa| F  
###
Google Drive Kelompok: https://drive.google.com/drive/folders/1JvKJdJCAzD9GjCQltspH8-gWIfkhsqZF  
Pengerjaan project: [Project Guideline](#project-guideline) (saran) 


## Ketentuan Project
- Project dikerjakan menggunakan C#
- Desain UI sesuai kebutuhan
- Tidak boleh menghilangkan atribut/entity yang diberikan
- Boleh menambahkan kreasi fitur (minimal 2 fitur)
- Konsultasi asdos minimal 2 kali

## Fitur Dasar
1) Pendaftaran User
   - Mendaftarkan diri dengan input data diri. Diantaranya: Nama lengkap, no KTP, foto diri, foto profil, email, dan username.
   - Menginputkan kisah hidup dari history sekolah SD, SMP, SMA, kuliah, serta tempat bekerja atau organisasi yang diikuti (jika ada), beserta dengan tahun kejadiannya.
   - _**Username tidak boleh sama dengan user lain**_. Login dilakukan dengan menginputkan username dan password.
2) Pencarian Teman
   - Mencari teman berdasarkan sekolah atau perusahaan tempat ia bekerja.
   - Saat permintaan pertemanan diajukan, teman wajib mengkonfirmasi permintaan tersebut. 
3) Percakapan
   - Setelah kedua user mengkonfirmasi pertemanan, kedua user ini dapat berkomunikasi melalui fitur percakapan.
   - Semua user dapat melihat percakapan yang telah dilakukan pada hari-hari sebelumnya. 
4) Konten, Tag, dan Komentar
   - Membuat konten berupa tulisan, gambar, dan kombinasinya. Dengan maksimum 1 tulisan, 1 gambar, dan 1 video pada sebuah post.
   - Dapat melakukan tag pada user lain yang telah menjadi teman.
   - Semua user yang terlibat dalam konten dapat memberikan masing-masing lebih dari 1 komentar pada konten tersebut. Yang terlibat dalam sebuah konten adalah pembuat konten, teman dari pembuat konten, dan yang di tag (teman).
  
## Fitur Tambahan
1) _(belum)_
2) _(belum)_

## Dokumentasi 
- Penjelasan cara kerja program secara umum.
- Susunan class, property, method yang dibuat, dan dilengkapi dengan penjelasan (misal: mengapa dibuat menjadi static, parameter yang ada digunakan untuk apa).
- Kreasi Fitur: Penjelasan fitur, cara kerja dan source code.
- Dokumentasi kerja kelompok, waktu, dan hasil kerja kelompok.
- Foto sesi konsultasi dengan asdos beserta waktu, dan hasil konsultasi.

## Penilaian 
|Kriteria|Bobot
|-|-|
Struktur OOP| 30%
UI dan Coding| 30%
Kreasi Fitur| 20%
Dokumentasi| 10%
Presentasi| 10%

Penilaian akan dilaksanakan pada minggu kedua UAS. Sesi penilaian akan dibagi menjadi sesi presentasi kelompok dan penilaian individu berupa tes coding. 
**Aturan:** 
- Semua kelompok wajib hadir, personel yang tidak hadir akan mendapatkan nilai 0.
- Semua anggota kelompok wajib melakukan presentasi.
- Durasi maksimal persentasi 10 menit.
- Pertanyaan akan diberikan kepada kelompok, penjawab dipilih secara acak oleh penguji.
- Durasi maksimal tanya jawab 5 menit.
- Penilaian individu dilaksanakan setelah sesi presentasi.
- Durasi tes individu per personel 3 menit.

## Pengumpulan
- Pengumpulan paling lambat _**Sabtu, 11 Januari 2025 pukul 20:00**_
- Pengumpulan diwakilkan oleh satu anggota kelompok
- Yang dikumpulkan adalah _**1 file zip**_ yang berisi: Dokumentasi project, project, ERD, file SQL yang berisi perintah pembuatan tabel dan data.
- Penamaan file: 21_Menyala DB kuu🚀🚀.ZIP  

Tempat Pengumpulan: https://uls.ubaya.ac.id/mod/assign/view.php?id=60187

# Project Guideline
Di project UAS ini ada beberapa hal yang mau aku sarankan salah satunya penggunaan [VCS](https://www.geeksforgeeks.org/version-control-systems/) yaitu Git & GitHub supaya kerjanya enak. Untuk panduannya ada di segmen bawah, bisa dicek. Terus juga tentang [Layered Architecture Pattern](https://priyalwalpita.medium.com/software-architecture-patterns-layered-architecture-a3b89b71a057) yang kusarankan kita pakai. Untuk yang satu ini udah kutanyain ke Pak DanSus dan udah diapprove. Di project OOP ku sebelumnya juga pake ini, bisa dicek di [sini](https://github.com/StaticKev/FoodWars). Bedanya untuk project kali ini aku tambahin satu layer lagi supaya lebih relate sama materi kita di kelas. 

## Version Control System (VCS) - _Git & Github_
Ndak perlu penjelasan, langsung step-step nya aja. Tapi kalo butuh penjelasan lengkap ada di course [ini](https://www.youtube.com/watch?v=lTMZxWMjXQU&list=PLFIM0718LjIVknj6sgsSceMqlq242-jNf).  
### 
**Langkah-langkah ini cukup diikuti sekali aja:**
1) Buka GitHub repository ku.
2) Fork repository ku ke akun GitHub kalian.
3) Clone repository yang baru aja kalian fork ke folder tujuan di laptop kalian (ini download, bukan sekedar project tapi Git repository, jadi ada history nya juga).
4) Buka project.
### 
**Langkah-langkah tiap kali mau buat perubahan:**
1) Buka GitHub kalian.
2) Buka repository dari project ini di GitHub kalian.
3) Pastikan ndak ada perubahan di repository ku (biasanya muncul notif di repo kalian).
4) Kalo ada perubahan, compare & pull request dulu.
5) Buka terminal di directory project ini (folder yang ada .git nya).
6) Ketik `git fetch`, lalu Enter.
7) Ketik `git pull`, lalu Enter.
8) Buat branch baru, ketik `git branch namaBranch`, lalu Enter.
9) Checkout ke branch yang baru aja kalian buat, ketik `git checkout namaBranch`, lalu Enter.
10) Buat perubahan di Visual Studio kemudian simpan.
11) Buka terminal lagi, tambahkan perubahan ke working directory dari git, ketik `git add .`, lalu Enter.
12) Commit perubahan, ketik `git commit -m "Tulis kalian ubah apa di sini."`, lalu Enter.
13) Checkout ke main branch, ketik `git checkout main`, lalu Enter.
14) Kemudian push perubahan ke repository di GitHub kalian, ketik `git push --set-upstream origin`, lalu Enter.
15) Hapus branch yang tadi dipakai `git branch -d namaBranch`, lalu Enter.
16) Kalau perubahan sudah kutarik, branch yang di GitHub repo boleh dihapus biar ndak ketumpuk. 

## Introduction to Software Architecture Pattern
Software architecture pattern itu singkatnya adalah sebuah rancangan yang bisa dijadikan pedoman untuk  seorang programmer supaya kode yang ditulis itu istilahnya lebih _bersih_. Dalam artian, kegunaan setiap class itu jelas (mengacu pada prinsip [_separation of concerns_](https://www.geeksforgeeks.org/separation-of-concerns-soc/)), perubahan pada sebuah fitur tidak akan berdampak pada fitur lainnya, dapat dikerjakan secara terpisah, dan mudah untuk diuji coba. Tiga hal yang kusebutin di akhir berkaitan tentang [modularitas](https://www.institutedata.com/blog/modularity-in-software-engineering/) sebuah perangkat lunak. Jadi nanti satu orang bisa ngerjain satu fitur tanpa tabrakan sama yang lain. Lebih gampang di manage juga.

### Layered Architecture Pattern
Sebuah pola arsitektur perangkat lunak yang paling sederhana. Pattern ini membagi kodingan kita jadi 3 bagian besar yaitu _Persistence Layer_, _Business Layer_, dan _Presentation Layer_. Dimulai dari yang paling bawah persistence layer, terdiri dari class yang digunakan untuk menyimpan data. Di kasus kita persistence layer itu meliputi _DAO_ dan _Repository Layer_. Business layer itu terdiri dari class yang isinya logic dari aplikasi, misal proses berteman antar user, posting, komentar, dll. Presentation layer itu terdiri dari class yang digunakan untuk menangani logic UI nya. Dalam hal ini ya class Form atau UserControl. Kotak abu-abu itu di dalam aplikasi, kotak biru di luar aplikasi (database). Di gambar yang kukasih di bawah, satu kotak itu menggambarkan satu class. Setiap fitur akan punya Repository, Service, dan Presentation layernya sendiri. Jadi nanti masing-masing dari kita bisa mengembangkan fitur-fitur secara terpisah tanpa ngerusak fitur lain atau tunggu-tungguan. Penjelasan dari masing-masing layer: 
- Database: Satu-satunya layer yang ada di luar aplikasi. Aplikasi bisa berinteraksi layer ini dengan membuka koneksi ke database server, menggunakan library yang kita pakai. 
- Data Access Object (DAO): Memisahkan antara perintah query dan entity yang kita buat (yang kumaksud entity itu class yang ada di class library dan di database). Selama ini kan kita membuat perintah query di class yang ada di class library. Misalnya, ada perintah query di class user. Class yang ada di Class Library itu full untuk mendefinisikan entitas yang berinteraksi dalam aplikasi kita beserta perilakunya. Gampangannya, masa sebuah komentar memiliki perilaku untuk membuat koneksi ke database. Kan ndak masuk akal. Perintah query nya bisa dimasukkan ke class DAO, yang menangani query pada masing-masing tabel (_entity_).
- Repository: Class Repository untuk menangani relasi antar objek yang terjadi di level aplikasi (aggregation). Misal kita query data dari 2 buah tabel yang berelasi. Waktu sampai di aplikasi, 2 buah objek dari tabel yang berelasi akan terhubung berdasarkan [reference](https://mvhs-fuhsd.org/john_conlin/Java/HW_folder_Java/ObjRef/L10ObjRef.html#:~:text=An%20object%20reference%20is%20information,about%20where%20the%20object%20is.) bukan ID lagi. Nah, class Repository akan ngurus masalah ini.
- Service: Ini business layer, biasanya disebut service soalnya mengacu pada satuan fitur dari aplikasi. Sesuai penjelasan di atas layer ini isinya logic untuk aplikasi. Biar ndak ada algoritma yang menangani proses pertemanan di class Form.
- Presentation: Basically class Form bedanya, nanti semua logic aplikasi bakalan dipindah ke service layer. Nanti juga kita pakai [UserControl](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls-design/usercontrol-overview?view=netdesktop-9.0). UserControl itu beda dari Form atau MDIForm. UserControl itu literally Form tapi ndak ada windows nya (bingkai yang ada tombol maximize, minimize, close). Itu bisa langsung dimasukkan kedalam Form pakai propery Controls dari sebuah Windows Form yang biasa kita buat, navigasinya juga sederhana. 
![LayeredArchitecture](https://github.com/user-attachments/assets/0b3a0fb2-633d-4989-add0-5c1090c04092)

### Contoh 
Sebuah aplikasi yang memiliki fitur pendaftaran mata kuliah dari mahasiswa di sebuah universitas. Seorang mahasiswa dapat mengambil sekurang-kurangnya 20 sks dan maksimum 24 sks. Ada 2 buah Entity Mahasiswa dan MataKuliah.   
### 
**Class MataKuliah**
```C#
 public class MataKuliah
 {
     private string namaMk;
     private int sks;

     public MataKuliah(string namaMk, int sks) { NamaMk = namaMk; Sks = sks; }

     public string NamaMk
     {
         get => namaMk;
         private set
         {
             if (value == "") throw new ArgumentException("This field can't be empty!");
             else if (value == null) throw new NullReferenceException("This field can't be null!");
             else namaMk = value;
         }
     }
     public int Sks 
     { 
         get => sks; 
         private set
         {
             if (value <= 0 || value > 4) throw new ArgumentOutOfRangeException("Invalid value for this field!");
             else sks = value;
         }
     }
 }
```
**Class Mahasiswa**
```C#
 public class Mahasiswa
 {
     private string nama, nrp;
     private int sks;
     private List<MataKuliah> mkDiambil;

     public Mahasiswa(string nama, string nrp) { Nama = nama; Nrp = nrp; Sks = 0; MkDiambil = new List<MataKuliah>(); }

     public string Nama
     {
         get => nama;
         private set
         {
             if (value == "") throw new ArgumentException("This field can't be empty!");
             else if (value == null) throw new NullReferenceException("This field can't be null!");
             else nama = value;
         }
     }
     public string Nrp
     {
         get => nrp;
         private set
         {
             if (value == "") throw new ArgumentException("This field can't be empty!");
             else if (value == null) throw new NullReferenceException("This field can't be null!");
             else if (value.Length > 9 || value.Length < 9) throw new ArgumentException("Invalid value for this field!");
             else nrp = value;
         }
     }
     public int Sks
     {
         get => sks;
         private set
         {
             if (value <= 0) throw new ArgumentException("Invalid value for this field!");
             else sks = value;
         }
     }
     public List<MataKuliah> MkDiambil
     {
         get => mkDiambil;
         private set
         {
             if (value == null) throw new NullReferenceException("This field can't be null!");
             else mkDiambil = value;
         }
     }

     public void TambahMataKuliah(MataKuliah mk)
     {
         if (Sks + mk.Sks > 24) throw new Exception("Kuota sks tidak mencukupi!");
         else
         {
             MkDiambil.Add(mk);
             Sks += mk.Sks;
         }
     }

     public void HapusMataKuliah(MataKuliah mk) 
     { 
         MkDiambil.Remove(mk);
         Sks -= mk.Sks;
     }
 }
```
### 
Setelah itu dapat dibuat DAO untuk masing-masing class. _**Disclaimer:**_ Yang ini kuambil dari ChatGPT, implementasi di aplikasi kita ngikuti yang diajari di kelas.  
**DAO untuk MataKuliah**
```C#
 public class MataKuliahDAO
 {
     private readonly string connectionString;

    public MataKuliahDAO(string connectionString) { this.connectionString = connectionString; }

     public void Insert(MataKuliah mataKuliah)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "INSERT INTO MataKuliah (namaMk, sks) VALUES (@namaMk, @sks)";
             
             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@namaMk", mataKuliah.NamaMk);
                 command.Parameters.AddWithValue("@sks", mataKuliah.Sks);

                 command.ExecuteNonQuery();
             }
         }
     }

     public MataKuliah GetById(int id)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "SELECT namaMk, sks FROM MataKuliah WHERE id = @id";
            
             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@id", id);

                 using (var reader = command.ExecuteReader())
                 {
                     if (reader.Read())
                     {
                         string namaMk = reader.GetString(0);
                         int sks = reader.GetInt32(1);
                         return new MataKuliah(namaMk, sks);
                     }
                 }
             }
         }
         return null;
     }

     public List<MataKuliah> GetAll()
     {
         var mataKuliahList = new List<MataKuliah>();

         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "SELECT namaMk, sks FROM MataKuliah";
            
             using (var command = new SqlCommand(query, connection))
             using (var reader = command.ExecuteReader())
             {
                 while (reader.Read())
                 {
                     string namaMk = reader.GetString(0);
                     int sks = reader.GetInt32(1);
                     mataKuliahList.Add(new MataKuliah(namaMk, sks));
                 }
             }
         }
         return mataKuliahList;
     } 

     public void Update(int id, MataKuliah mataKuliah)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "UPDATE MataKuliah SET namaMk = @namaMk, sks = @sks WHERE id = @id";
            
             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@namaMk", mataKuliah.NamaMk);
                 command.Parameters.AddWithValue("@sks", mataKuliah.Sks);
                 command.Parameters.AddWithValue("@id", id);

                 command.ExecuteNonQuery();
             }
         } 
     } 

     public void Delete(int id)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "DELETE FROM MataKuliah WHERE id = @id";
             
             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@id", id);
                 command.ExecuteNonQuery();
             }
         }
     }
 }
```
**DAO untuk Mahasiswa**
```C#
 public class MahasiswaDAO
 {
     private readonly string connectionString;

     public MahasiswaDAO(string connectionString) { this.connectionString = connectionString; }

     public void Insert(Mahasiswa mahasiswa)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "INSERT INTO Mahasiswa (nama, nrp, sks) VALUES (@nama, @nrp, @sks)";
            
             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@nama", mahasiswa.Nama);
                 command.Parameters.AddWithValue("@nrp", mahasiswa.Nrp);
                 command.Parameters.AddWithValue("@sks", mahasiswa.Sks); 

                 command.ExecuteNonQuery();
             }
         }
     }
 
     public Mahasiswa GetById(int id)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "SELECT nama, nrp, sks FROM Mahasiswa WHERE id = @id";
            
             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@id", id);

                 using (var reader = command.ExecuteReader())
                 {
                     if (reader.Read())
                     {
                         string nama = reader.GetString(0);
                         string nrp = reader.GetString(1);
                         int sks = reader.GetInt32(2);
                         return new Mahasiswa(nama, nrp) { Sks = sks };
                     }
                 } 
             }
         }
         return null;
     }

     public List<Mahasiswa> GetAll()
     {
         var mahasiswaList = new List<Mahasiswa>(); 

         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "SELECT nama, nrp, sks FROM Mahasiswa";
             
             using (var command = new SqlCommand(query, connection))
             using (var reader = command.ExecuteReader())
             {
                 while (reader.Read())
                 {
                     string nama = reader.GetString(0);
                     string nrp = reader.GetString(1);
                     int sks = reader.GetInt32(2);
                     mahasiswaList.Add(new Mahasiswa(nama, nrp) { Sks = sks });
                 }
             }
         }
         return mahasiswaList;
     } 

     public void Update(int id, Mahasiswa mahasiswa)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "UPDATE Mahasiswa SET nama = @nama, nrp = @nrp, sks = @sks WHERE id = @id";
            
             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@nama", mahasiswa.Nama);
                 command.Parameters.AddWithValue("@nrp", mahasiswa.Nrp);
                 command.Parameters.AddWithValue("@sks", mahasiswa.Sks);
                 command.Parameters.AddWithValue("@id", id);

                 command.ExecuteNonQuery();
             }
         }
     }

     public void Delete(int id)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "DELETE FROM Mahasiswa WHERE id = @id";
             
             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@id", id);
                 command.ExecuteNonQuery();
             }
         }
     }
 }
```
Kemudian membuat class repository. Implementasi yang ini juga kuambil dari ChatGPT. Harusnya perintah query yang di sini masuk ke DAO nya mata kuliah.  
**Repository untuk fitur pendaftaran mata kuliah**
```C#
  public class MahasiswaRepository
  {
      private readonly MahasiswaDAO mahasiswaDAO;
      private readonly MataKuliahDAO mataKuliahDAO;
      private readonly string connectionString; 

      public MahasiswaRepository(string connectionString)
      {
          this.connectionString = connectionString;
          this.mahasiswaDAO = new MahasiswaDAO(connectionString);
          this.mataKuliahDAO = new MataKuliahDAO(connectionString);
      }

      public Mahasiswa GetMahasiswaWithCourses(int mahasiswaId)
      {
          // Retrieve Mahasiswa by ID
          Mahasiswa mahasiswa = mahasiswaDAO.GetById(mahasiswaId);

         if (mahasiswa != null) mahasiswa.MkDiambil = GetMataKuliahForMahasiswa(mahasiswaId); 
         return mahasiswa;
     }

     private List<MataKuliah> GetMataKuliahForMahasiswa(int mahasiswaId)
     {
         var mataKuliahList = new List<MataKuliah>();

         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "SELECT mk.namaMk, mk.sks FROM MahasiswaMataKuliah mmk " +
                            "JOIN MataKuliah mk ON mmk.mataKuliahId = mk.id " +
                            "WHERE mmk.mahasiswaId = @mahasiswaId";

             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@mahasiswaId", mahasiswaId);

                 using (var reader = command.ExecuteReader())
                 {
                     while (reader.Read())
                     {
                         string namaMk = reader.GetString(0);
                         int sks = reader.GetInt32(1);
                         mataKuliahList.Add(new MataKuliah(namaMk, sks));
                     }
                 }
             }
         }

         return mataKuliahList;
     }

     public void RemoveMataKuliahFromMahasiswa(int mahasiswaId, int mataKuliahId)
     {
         using (var connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "DELETE FROM MahasiswaMataKuliah WHERE mahasiswaId = @mahasiswaId AND mataKuliahId = @mataKuliahId";

             using (var command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@mahasiswaId", mahasiswaId);
                 command.Parameters.AddWithValue("@mataKuliahId", mataKuliahId);

                 command.ExecuteNonQuery();
             }
         }

         // Update the Sks count for the Mahasiswa after removing the MataKuliah
         var mahasiswa = mahasiswaDAO.GetById(mahasiswaId);
         if (mahasiswa != null)
         {
             var mataKuliah = mataKuliahDAO.GetById(mataKuliahId);
             if (mataKuliah != null)
             {
                 mahasiswa.Sks -= mataKuliah.Sks;
                 mahasiswaDAO.Update(mahasiswaId, mahasiswa);
             }
         }
     }
 }
```
Terakhir service layer, yang isinya logic untuk pendaftaran mata kuliah mahasiswa. Presentation layer ndak kumasukin soalnya berkaitan sama desain UI. Ini juga kuambil dari GPT, harusnya DAP ndak boleh di inject langsung ke service.  
**Service untuk fitur pendaftaran mata kuliah**
```C#
 public class MahasiswaService
 {
     private readonly MahasiswaRepository mahasiswaRepository;
     private readonly MataKuliahDAO mataKuliahDAO;

     // Constructor injection for MahasiswaRepository and MataKuliahDAO
     public MahasiswaService(MahasiswaRepository mahasiswaRepository, MataKuliahDAO mataKuliahDAO)
     {
         this.mahasiswaRepository = mahasiswaRepository;
         this.mataKuliahDAO = mataKuliahDAO;
     }

     // Assign MataKuliah to Mahasiswa
     public void AssignMataKuliahToMahasiswa(int mahasiswaId, int mataKuliahId)
     {
         // Retrieve Mahasiswa and MataKuliah from the database
         Mahasiswa mahasiswa = mahasiswaRepository.GetMahasiswaWithCourses(mahasiswaId);
         MataKuliah mataKuliah = mataKuliahDAO.GetById(mataKuliahId);

         if (mahasiswa == null)
         {
             throw new Exception("Mahasiswa not found.");
         }

         if (mataKuliah == null)
         {
             throw new Exception("MataKuliah not found.");
         }

         // Check if the total SKS after assignment exceeds the limit
         if (mahasiswa.Sks + mataKuliah.Sks > 24)
         {
             throw new Exception("SKS quota exceeded. Cannot assign this course.");
         }

         // Add MataKuliah to Mahasiswa's course list and update SKS
         mahasiswa.TambahMataKuliah(mataKuliah);

         // Update Mahasiswa in the database to save the new SKS count and course assignment
         mahasiswaRepository.mahasiswaDAO.Update(mahasiswaId, mahasiswa);
     }
 }
```
