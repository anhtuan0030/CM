using Cirrious.CrossCore.IoC;

namespace CM.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				


            RegisterAppStart<ViewModels.FirstViewModel>();

            RegisterAppStart<ViewModels.TeacherViewModel>();
            RegisterAppStart<ViewModels.StudentViewModel>();
            RegisterAppStart<ViewModels.CourseViewModel>();

        }
    }
}