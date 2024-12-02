using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using UAS_DB_PamerYuk.F1_UserManager;
using UAS_DB_PamerYuk.F2_Friendship;
using UAS_DB_PamerYuk.F2_Friendship.View;
using UAS_DB_PamerYuk.F3_Chat;
using UAS_DB_PamerYuk.F3_Chat.View;
using UAS_DB_PamerYuk.F4_Content;
using UAS_DB_PamerYuk.F4_Content.View;

namespace UAS_DB_PamerYuk
{
    public partial class MainForm : Form
    {

        private readonly Connection connection;
        private Control currentMenu;

        public MainForm(Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
            currentMenu = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ContentService service = new ContentService(connection.DbConnection);
            ContentUC_P uc = new ContentUC_P(service, this);

            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void homeButton_OnClick(object sender, EventArgs e)
        {
            if (currentMenu is ContentUC_P) return;

            homeButton.Image = Properties.Resources.HomeButton_clicked;
            ResetButton();

            ContentService service = new ContentService(connection.DbConnection);
            ContentUC_P uc = new ContentUC_P(service, this);

            mainPanel.Controls.Remove(currentMenu);
            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void searchButton_OnClick(object sender, EventArgs e)
        {
            if (currentMenu is SearchUC_P) return;

            searchButton.Image = Properties.Resources.SearchButton_clicked;
            ResetButton();

            FriendshipService service = new FriendshipService(connection.DbConnection);
            SearchUC_P uc = new SearchUC_P(service, this);

            mainPanel.Controls.Remove(currentMenu);
            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void chatButton_OnClick(object sender, EventArgs e)
        {
            if (currentMenu is ChatListUC_P) return;

            chatButton.Image = Properties.Resources.ChatButton_clicked;
            ResetButton();

            ChatService service = new ChatService(connection.DbConnection);
            ChatListUC_P uc = new ChatListUC_P(service, this);

            mainPanel.Controls.Remove(currentMenu);
            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void profileButton_OnClick(object sender, EventArgs e)
        {
            if (currentMenu is ProfileUC_P) return;

            profileButton.Image = Properties.Resources.ProfileButton_clicked;
            ResetButton();

            UserManagerService service = new UserManagerService(connection.DbConnection);
            ProfileUC_P uc = new ProfileUC_P(service, this);

            mainPanel.Controls.Remove(currentMenu);
            currentMenu = uc;
            mainPanel.Controls.Add(uc);
        }

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            homeButton.Image = Properties.Resources.HomeButton_clicked;
        }

        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.Image = Properties.Resources.SearchButton_clicked;
        }

        private void chatButton_MouseEnter(object sender, EventArgs e)
        {
            chatButton.Image = Properties.Resources.ChatButton_clicked;
        }

        private void profileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.Image = Properties.Resources.ProfileButton_clicked;
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            if (!(currentMenu is ContentUC_P)) homeButton.Image = Properties.Resources.HomeButton;
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            if (!(currentMenu is SearchUC_P)) searchButton.Image = Properties.Resources.SearchButton;
        }

        private void chatButton_MouseLeave(object sender, EventArgs e)
        {
            if (!(currentMenu is ChatListUC_P)) chatButton.Image = Properties.Resources.ChatButton;
        }

        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            if (!(currentMenu is ProfileUC_P)) profileButton.Image = Properties.Resources.ProfileButton;
        }

        private void ResetButton()
        {
            if (currentMenu is ContentUC_P) homeButton.Image = Properties.Resources.HomeButton;
            else if (currentMenu is SearchUC_P) searchButton.Image = Properties.Resources.SearchButton;
            else if (currentMenu is ChatListUC_P) chatButton.Image = Properties.Resources.ChatButton;
            else if (currentMenu is ProfileUC_P) profileButton.Image = Properties.Resources.ProfileButton;
        }
    }
}
