�}�[  W  �G	'��oC�u
 xTF�^k�p���� �"��s�Mr���O6�^�տiy�#C ��>c�^3(���⸾��T��	��J0t>����Ȥ����y�ޤ��$����v����UA�1}�Ӆ�)ށ�03�.q��KA�oUEy�A{)����뺕� j�/Y�pet��a$\���s��G_�JReo�n��2�8	�v���������R=s6�Q_�MA
��C��,�_B*$��������P&K�#g���;���ջ��/9K���~GקE��m�Ѱ�
xɻh
��{��k�{�n;�>���%X�K͂0l�a{�vb�u�c�'BF[��6���X.cTl�A4TK��
����/�W�?�.�XS��g�Jk{������5��$G϶	2���6�p�^A�v�����M-����$u��_�KL�pD�$5t�2�fr>�؉im�I�ѽOM�l�:Rkc�&�y�Z8D��{�5j�p

        public override bool Equals(object obj)
        {
            TextSample other = obj as TextSample;
            return other != null && Text == other.Text;
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }

        public override string ToString()
        {
            return Text;
        }
    }
}