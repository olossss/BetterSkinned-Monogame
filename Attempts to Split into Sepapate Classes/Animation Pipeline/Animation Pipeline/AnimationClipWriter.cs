﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using AnimationAux;

namespace AnimationPipeline
{
    [ContentTypeWriter]
    public class AnimationClipWriter : ContentTypeWriter<AnimationClip>
    {
        protected override void Write(ContentWriter output, AnimationClip clip)
        {
            output.Write(clip.Name);
            output.Write(clip.Duration);
            output.Write(clip.Bones.Count);
            foreach (AnimationClip.Bone bone in clip.Bones)
            {
                output.Write(bone.Name);
                output.Write(bone.Keyframes.Count);
                foreach (AnimationClip.Keyframe keyframe in bone.Keyframes)
                {
                    output.Write(keyframe.Time);
                    output.Write(keyframe.Rotation);
                    output.Write(keyframe.Translation);
                }
            }
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return typeof(AnimationClipReader).AssemblyQualifiedName;
        }
    }
}
