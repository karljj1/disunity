namespace DISUnity.Resources
{
    /// <summary>
    /// Collection of tooltips for anything DISUnity GUI related.
    /// Could have support for multiple languages...    
    /// </summary>
    internal class Tooltips
    {
        public const string ADSB = "Is the entity capable of Automatic Dependent Surveillance - Broadcast (ADS-B)?";

        public const string AlternativeEntityType = "This identifies the entity type to be displayed by members of forces other than that " +
                                                    "of the issuing entity. This could be used to represent an entity in disguise.";

        public const string AmmoSupply = "Does the entity have an ammunition supply?";

        public const string ApplicationID = "An application is defined as a software program that is used to generate " +
                                            "and process distributed simulation data including live, virtual and " +
                                            "constructive data. Each application participating in an event (e.g., " +
                                            "training exercise) shall be assigned a unique Application Number for the " +
                                            "site with which the application is associated.";

        public const string ArticulatedPartsClass = "Identifies a particular articulated part on a given entity type.";

        public const string ArticulatedPartsMetric = "The transformation to be applied to the articulated part.";

        public const string CollidingEntityID = "Entity that has collided with the issuing entity. If collision is with terrain or an unknown entity the id will be ENTITY_ID_UNKNOWN";

        public const string DataLength = "The number of bits of digital voice audio or digital data being sent in the PDU.";

        public const string DeadReckoningAlgorithm = "The Dead Reckoning Algorithms consist of 3 elements.\n" +
                                                     "DRM_X_Y_Z\n" +
                                                     "X - Specifies rotation as either fixed(F) or rotating(R).\n" +
                                                     "Y - Specifies dead reckoning rates to be held constant as " +
                                                     "either rate of position (P) or rate of velocity (V).\n" +
                                                     "Z - Specifies the coordinate system as either world " +
                                                     "coordinates (W) or body axis coordinates(B).\n\n" +
                                                     "F_P_W    -   Constant velocity (or low acceleration)linear " +
                                                     "motion.\n" +
                                                     "R_P_W    -   Similar to F_P_W but where orientation is " +
                                                     "required (e.g. visual simulation).\n" +
                                                     "R_V_W    -   Similar to F_V_W but where orientation is " +
                                                     "required (e.g. visual simulation).\n" +
                                                     "F_V_W    -   High speed or manoeuvring  at any speed (e.g. " +
                                                     "TBM, ICBM, SAM, SSM, and ASM weapons.\n" +
                                                     "F_P_B    -   Similar to R_P_W but when body-centred " +
                                                     "calculation is preferred.\n" +
                                                     "R_P_B    -   Similar to R_V_W but when body-centred " +
                                                     "calculation is preferred.\n" +
                                                     "R_V_B    -   Similar to F_V_W but when body-centred " +
                                                     "calculation is preferred.\n" +
                                                     "F_V_B    -   Similar to F_P_B but when body-centred " +
                                                     "calculation is preferred.";

        public const string Descriptor = "Describes the firing or launch of a munition or expendable.";

        public const string EntityCategory = "Main category that describes the entity";

        public const string EntityCountry = "Country to which the design of the entity or its design specification is attributed.";

        public const string EntityExtra = "Extra information required to describe a particular entity.";

        public const string EntityDomain = "The domain in which the entity operates (e.g., subsurface, surface, and land) except for " +
                                           "munition entities. For munition entities this field shall specify the domain of the target " +
                                           "(for example, the munition might be a surface-to-air, so the domain would be anti-air).";

        public const string EntityID = "Unique designation of each entity in an event or exercise";

        public const string EntityKind = "Kind of entity";

        public const string EntityMarking = "The name of the entity. Max 12 characters. Currently only ASCII marking is supported.";

        public const string EntitySpecific = "Specific information about an entity based on the Subcategory field.";

        public const string EntitySubCategory = "A particular subcategory to which an entity belongs based on the Category field.";

        public const string EventID = "ID generated to associate related events to this one.";

        public const string ExerciseID = "Unique to each exercise being conducted simultaneously. Value should be between 0 and 255.";

        public const string ExplosiveForce = "The explosive force expressed as the equivalent kilograms of TNT (4.184 x 106 Joules per kilogram).";

        public const string FiringID = "The ID of the firing entity";

        public const string FireMissionIndex = "Identifies the fire mission. If unknown value will be symbolic value: NO_FIRE_MISSION.";

        public const string FuelSupply = "Does the entity have a fuel supply?";

        public const string HeartBeat = "How often in seconds to send an update out to the DIS network if an entity has had no changes.";

        public const string InternalDataType = "Interpret the internal data as this type.";

        public const string IssuingEntityID = "Entity issuing the collision event.";

        public const string LocationCollision = "The location of the collision with respect to the entity with which the issuing entity " +
                                                "collided. Entity Coordinate Vector: Location relative to a particular entity shall be " +
                                                "specified with respect to the origin of the entity�s coordinate system.";

        public const string Mass = "The mass of the issuing entity in kilograms.";

        public const string MuntionID = "The ID of the fired munition or expendable.";

        public const string MunitionLocation = "Location from which the munition was launched.";

        public const string Orientation = "Orientation of entity in euler using radians.";

        public const string ProtocolFamily = "The family of protocols to which the PDU belongs.";

        public const string ProtocolVersion = "Minimum version of DIS required to read this PDU.";

        public const string RadioNumber = "Identifies a radio/communications device belonging to the entity. IDs should be assigned sequentially " +
                                          "to entities, starting with 1. Also known as Radio Number in DIS 7. Note: The combination of the Radio " +
                                          "Reference ID and the Radio Number field uniquely identifies a particular radio within a simulation " +
                                          "exercise. This combination is referred to as the Radio Identifier. The Radio Identifier is used to " +
                                          "associate Transmitter, Signal, and Receiver PDUs with the same radio.";

        public const string RadioReferenceID = "For attached radios, this field should identify the Entity Identifier record " +
                                               "or Object Identifier record to which the radio is attached. For unattached " +
                                               "radios, this field should contain the Unattached Identifier record. Note: The " +
                                               "combination of the Radio Reference ID and the Radio Number field uniquely " +
                                               "identifies a particular radio within a simulation exercise. This combination " +
                                               "is referred to as the Radio Identifier. The Radio Identifier is used to " +
                                               "associate Transmitter, Signal, and Receiver PDUs with the same radio.";

        public const string Range = "The range that an entity�s fire control system has assumed in computing the fire control solution. 0 if unknown.";

        public const string ReceivePollFrequency = "How often to check the connection for new data.";

        public const string RecoveryService = "Does the entity provide a recovery service?";

        public const string RefreshRate = "How often to poll/perform operation in seconds.";

        public const string RepairService = "Does the entity provide a repair service?";

        public const string SampleRate = "Sample rate in samples per second if the encoding class is encoded audio or the data rate in bits per second for data transmissions.";

        public const string SiteID = "A site is defined as a facility, installation, organizational unit or a geographic " +
                                      "location that has one or more simulation applications capable of participating in a" +
                                      "distributed event. A facility, installation, organizational unit or geographic location " +
                                      "may have multiple sites associated with it. Each site participating in an event (e.g., " +
                                      "training exercise, experiment, test) shall be assigned a unique Site Number that is " +
                                      "different from any other site that is part of the same event.";

        public const string StartConnectionOnPlay = "Should the connection start at the begining of the sim or wait until started by an other source(E.G Connection Editor GUI)?";

        public const string TargetID = "The ID of the entity being targeted";

        public const string TimeStampTime = "Time value. Scale of the time is determined by setting one hour equal to (2^31 - 1) " +
                                            "thereby resulting in each time unit representing 3600 s/( 2^31 - 1 ) = 1.676 " +
                                            "micro secs or 0.000001676 seconds.";

        public const string TimeStampType = "Absolute - Used when all simulation clocks are synchronized to UTC\n\n" +
                                            "Relative - Used when clocks are not synchronized, Each sim shall keep time begging with an " +
                                            "arbitrary starting point. The timestamp represents units of time passed since the beginning " +
                                            "of the current hour.";

        public const string UsePDUBundles = "Network efficiency may be enhanced with PDU bundling. This is the process of concatenating two or more " +
                                            "PDUs into a single network datagram so that they may be transmitted and relayed through the network in a " +
                                            "single operation. In DISUnity the Send function will concatenate PDU's into a bundle which will then be sent " +
                                            "periodically(set by the bundle send freq variable). If not enabled PDU will be sent instantly when the Send function is called. " +
                                            "Note: This feature may not be supported by some DIS applications, if you are unsure then it is safer not to use it. ";

        public const string VelocityWarfare = "The velocity of the fired munition at the point when the issuing simulation application intends the " +
                                              "externally visible effects of the launch (e.g., exhaust plume or muzzle blast) to first become apparent. " +
                                              "Represented in world coordinates. Meters per second.";

        public const string VelocityCollision = "The velocity (at the simulation time the collision is detected) of the issuing entity in world coordinates.";

        public const string WorldCoordinates = "World coordinate system.\n" +
                                               "Using a right-handed, geocentric Cartesian coordinate system.\n" +
                                               "The origin of the coordinate system is the centroid of the World " +
                                               "Geodetic System 1984 (WGS 84) reference frame.\n" +
                                               "Scale is 1 unit equals 1m.";

    }
}