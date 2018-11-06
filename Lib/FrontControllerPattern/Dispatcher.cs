using System;

namespace Lib.FrontControllerPattern
{
    public class Dispatcher
    {
        private StudentView studentView;
        private HomeView homeView;

        public Dispatcher()
        {
            studentView = new StudentView();
            homeView = new HomeView();
        }

        public void Dispatch(string request)
        {
            if(request == "Student")
            {
                studentView.Show();
            }
            else 
            {
                homeView.Show();
            }
        }
    }
}
