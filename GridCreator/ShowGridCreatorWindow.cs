﻿using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Design;
using System.Globalization;
using EnvDTE;
using EnvDTE80;
using GridCreator.Commands;
using GridCreator.View;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Utilities;

namespace GridCreator
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class ShowGridCreatorWindow
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("aca1c21e-5df0-497c-bff4-7c08b6cc0eb4");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowGridCreatorWindow"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private ShowGridCreatorWindow(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new OleMenuCommand(this.MenuItemCallback, menuCommandID);
                menuItem.BeforeQueryStatus += new EventHandler(OnBeforeQueryStatus);
                commandService.AddCommand(menuItem);
            }
        }
        
        private void OnBeforeQueryStatus(object sender, EventArgs e)
        {
            var menuCommand = sender as OleMenuCommand;
            var dte = ServiceProvider.GetService(typeof(DTE)) as DTE2;
            var documentLanguage = dte.ActiveDocument.Language.ToLower();

            if (documentLanguage == "htmlx")
                menuCommand.Visible = true;
            else
                menuCommand.Visible = false;

        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static ShowGridCreatorWindow Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package)
        {
            Instance = new ShowGridCreatorWindow(package);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        /// 
        private void MenuItemCallback(object sender, EventArgs e)
        {
            var GridCreatorDialog = new GridCreatorWindow();
            GridCreatorDialog.ShowDialog();

        }

        public void test()
        {
            var dte = ServiceProvider.GetService(typeof(DTE)) as DTE2;

            TextSelection ActiveDocumentCode = (TextSelection)(dte.ActiveDocument.Selection);
            ActiveDocumentCode.Insert("\r<div>\r<p>test></p>\r</div>", System.Convert.ToInt32(vsInsertFlags.vsInsertFlagsInsertAtEnd));
            ActiveDocumentCode = (TextSelection)(dte.ActiveDocument.Selection);
            ActiveDocumentCode.SmartFormat();
        }
    }
}
