//Entity.h
#pragma once
#include "ManagedObject.h"
#include "../CPlusPlus/Core.h"
using namespace System;
namespace CLI
{
    public ref class Entity : public ManagedObject<Core::Entity>
    {
    public:

        Entity(String^ name, float xPos, float yPos);
        void Move(float deltaX, float deltaY);
        int add(int a, int b);
        property float XPosition
        {
        public:
            float get()
            {
                return m_Instance->GetXPosition();
            }
        private:
            void set(float value)
            {
            }
        }
        property float YPosition
        {
        public:
            float get()
            {
                return m_Instance->GetYPosition();
            }
        private:
            void set(float value)
            {
            }
        }
    };
}