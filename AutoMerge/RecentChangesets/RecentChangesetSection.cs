﻿using AutoMerge.Base;
using Microsoft.TeamFoundation.Controls;

namespace AutoMerge
{
	[TeamExplorerSection(GuidList.RecentChangesetsSectionId, GuidList.AutoMergePageId, 10)]
	public class RecentChangesetSection : TeamExplorerSectionBase
	{
		private static readonly object _view;

		static RecentChangesetSection()
		{
			_view = new RecentChangesetsView();
		}

		protected override ITeamExplorerSection CreateViewModel(SectionInitializeEventArgs e)
		{
			var viewModel = base.CreateViewModel(e) ?? new RecentChangesetViewModel();

			return viewModel;
		}

		protected override object CreateView(SectionInitializeEventArgs e)
		{
			return _view;
		}
	}
}