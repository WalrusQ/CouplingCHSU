using Autofac;
using CouplingAlturos.Abstractions;
using CouplingAlturos.Core;

namespace CouplingAlturos
{
	public class RegistrationService
	{
		public static IContainer CreateContainer()
		{
			var builder = new ContainerBuilder();

			builder
				.RegisterType<Detector>()
				.As<IDetector>()
				.SingleInstance();

			builder
				.RegisterType<Logger>()
				.As<ILogger>()
				.SingleInstance();

			builder
				.RegisterType<MainForm>()
				.AsSelf();

			var container = builder.Build();

			return container;
		}
	}
}