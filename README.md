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
Sebuah aplikasi yang memiliki fitur untuk mencatat perubahan mata kuliah dari mahasiswa di sebuah universitas. Seorang mahasiswa dapat mengambil sekurang-kurangnya 20 sks dan maksimum 24 sks. Ada 2 buah Entity Mahasiswa dan MataKuliah.  
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
