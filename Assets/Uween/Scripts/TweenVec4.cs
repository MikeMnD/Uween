﻿using UnityEngine;

namespace Uween
{
	public abstract class TweenVec4 : Tween
	{
		protected static T Add<T>(GameObject g, float duration) where T : TweenVec4
		{
			return Add<T>(g, duration);
		}

		protected static T Add<T>(GameObject g, float duration, Vector4 to) where T : TweenVec4
		{
			var t = Add<T>(g, duration);
			t.to = to;
			return t;
		}

		protected static T Add<T>(GameObject g, float duration, float x, float y, float z, float w) where T : TweenVec4
		{
			return Add<T>(g, duration, new Vector4(x, y, z, w));
		}

		public Vector4 from;
		public Vector4 to;

		public abstract Vector4 value { get; set; }

		override protected void Reset()
		{
			base.Reset();
			from = value;
			to = value;
		}

		override protected void UpdateValue(float f)
		{
			value = from + (to - from) * f;
		}

		public TweenVec4 Relative()
		{
			to += value;
			return this;
		}

		public TweenVec4 FromRleative(Vector4 v)
		{
			from = value + v;
			value = from;
			return this;
		}

		public TweenVec4 FromRleative(float x, float y, float z, float w)
		{
			return FromRleative(new Vector4(x, y, z, w));
		}

		public TweenVec4 FromRleative(float v)
		{
			return FromRleative(v, v, v, v);
		}

		public TweenVec4 By()
		{
			return Relative();
		}

		public TweenVec4 From(Vector4 v)
		{
			from = v;
			value = from;
			return this;
		}

		public TweenVec4 From(float x, float y, float z, float w)
		{
			return From(new Vector4(x, y, z, w));
		}

		public TweenVec4 From(float v)
		{
			return From(v, v, v, v);
		}

		public TweenVec4 FromBy(Vector4 v)
		{
			return FromRleative(v);
		}

		public TweenVec4 FromBy(float x, float y, float z, float w)
		{
			return FromRleative(x, y, z, w);
		}

		public TweenVec4 FromBy(float v)
		{
			return FromRleative(v);
		}

		public TweenVec4 FromThat()
		{
			from = to;
			to = value;
			value = from;
			return this;
		}

		public TweenVec4 FromThatBy()
		{
			from = value + to;
			to = value;
			value = from;
			return this;
		}
	}
}
