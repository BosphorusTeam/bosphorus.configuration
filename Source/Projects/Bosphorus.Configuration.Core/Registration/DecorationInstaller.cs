﻿using Bosphorus.Configuration.Core.Decoration.Exception;
using Bosphorus.Configuration.Core.Decoration.SafeGet;
using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Installerr;
using Bosphorus.Container.Castle.Registration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Configuration.Core.Registration
{
    public class DecorationInstaller: AbstractWindsorInstaller, IDecoratorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Decorator
                    .For<IParameterProvider>()
                    .Is<SafeGetDecorator>()
                    .Is<ExceptionDecorator>()
            );
        }
    }
}