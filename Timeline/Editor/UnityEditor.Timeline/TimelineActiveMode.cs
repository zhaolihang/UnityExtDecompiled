using System;

namespace UnityEditor.Timeline
{
	internal class TimelineActiveMode : TimelineMode
	{
		public TimelineActiveMode()
		{
			base.headerState = new TimelineMode.HeaderState
			{
				breadCrumb = TimelineModeGUIState.Enabled,
				options = TimelineModeGUIState.Enabled,
				sequenceSelector = TimelineModeGUIState.Enabled
			};
			base.trackOptionsState = new TimelineMode.TrackOptionsState
			{
				newButton = TimelineModeGUIState.Enabled,
				editAsAssetButton = TimelineModeGUIState.Hidden
			};
		}

		public override bool ShouldShowTimeCursor(TimelineWindow.TimelineState state)
		{
			return true;
		}

		public override bool ShouldShowPlayRange(TimelineWindow.TimelineState state)
		{
			return state.playRangeEnabled;
		}

		public override TimelineModeGUIState ToolbarState(TimelineWindow.TimelineState state)
		{
			return TimelineModeGUIState.Enabled;
		}

		public override TimelineModeGUIState TrackState(TimelineWindow.TimelineState state)
		{
			return TimelineModeGUIState.Enabled;
		}
	}
}
