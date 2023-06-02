using MediatorPattern.Mediators;

namespace MediatorPattern.Components;
public abstract class BaseComponent
{
	protected IMediator _mediator;

	public IMediator MediatorSetter { set { _mediator = value; } }

	public BaseComponent(IMediator mediator)
	{
		_mediator = mediator;
	}
}
