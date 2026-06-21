using Godot;

namespace Game.Godot.Map;

public partial class MapEntityTooltip : PanelContainer
{
	private RichTextLabel _richTextLabel = null!;
	private string _text = string.Empty;
	
	public override void _Ready()
	{
		_richTextLabel = GetNode<RichTextLabel>("%RichTextLabel");
		Refresh();
	}

	public void Setup(string text)
	{
		_text = text;
		Refresh();
	}

	private void Refresh()
	{
		if (!IsInsideTree())
		{
			return;
		}

		_richTextLabel.Text = _text;
	}
}
