using Content.Server.Shuttles.Systems;
using Robust.Shared.Map;
using System.Numerics;

namespace Content.Server.Shuttles.Components;

/// <summary>
/// Component used to store the original docking relationships of ships prior to FTL.
/// This allows maintaining their relative positions when arriving at a new destination.
/// </summary>
[RegisterComponent, Access(typeof(ShuttleSystem))]
public sealed partial class FTLOriginalPositionsComponent : Component
{
    /// <summary>
    /// Dictionary mapping docked ship Entity UIDs to their position and rotation relative to the main shuttle
    /// </summary>
    [DataField]
    public Dictionary<EntityUid, (Vector2 RelativePosition, Angle RelativeRotation)> RelativePositions = new();
    
    /// <summary>
    /// Original map Entity UID the shuttle was on - kept for reference
    /// </summary>
    [DataField]
    public EntityUid? OriginalMapUid;
    
    /// <summary>
    /// Original position of the main shuttle - kept for reference
    /// </summary>
    [DataField]
    public EntityCoordinates? OriginalPosition;
    
    /// <summary>
    /// Original rotation of the main shuttle - kept for reference
    /// </summary>
    [DataField]
    public Angle OriginalAngle;
    
    /// <summary>
    /// Stores the original docking connections between ships
    /// </summary>
    [DataField]
    public Dictionary<EntityUid, List<(EntityUid DockA, EntityUid DockB)>> DockingConnections = new();
} 