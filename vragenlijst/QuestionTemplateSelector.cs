﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using vragenlijst.Domain;

namespace vragenlijst
{
    public class QuestionDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate
            SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null)
            {
              

                if (item is SliderQuestion)
                    return
                        element.FindResource("sliderQ") as DataTemplate;
                else
                    return
                        element.FindResource("textQ") as DataTemplate;
            }

            return null;
        }
    }
}