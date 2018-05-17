﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.UIElements;
using UnityEngine.Experimental.UIElements;

namespace GraphProcessor
{
	[NodeCustomEditor(typeof(IntNode))]
	public class IntNodeView : BaseNodeView
	{
		public override void Enable()
		{
			var intNode = nodeTarget as IntNode;
			
			IntegerField	intField = new IntegerField();

			intField.value = intNode.output;

			intField.OnValueChanged((v) => {
				intNode.output = (int)v.newValue;
				owner.graph.RegisterCompleteObjectUndo("Updated IntNode output");
			});

			controlsContainer.Add(intField);
		}
	}
}